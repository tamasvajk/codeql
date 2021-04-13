import sys
import os
import subprocess


def run_cmd(cmd):
    print('Running ' + ' '.join(cmd))
    if subprocess.check_call(cmd):
        print("Failed to run command")
        exit(1)


def get_argv(index, default):
    if len(sys.argv) > index:
        return sys.argv[index]
    return default


print('Script to generate stub.cs file from a nuget package')
print('Usage: python ' + sys.argv[0] +
      ' NUGET_PACKAGE_NAME [WORK_DIR] [OUTPUT_NAME]')

if len(sys.argv) < 2:
    print("\nPlease supply a nuget package name.")
    exit(1)

thisScript = sys.argv[0]
thisDir = os.path.abspath(os.path.dirname(thisScript))
nuget = sys.argv[1]

workDir = os.path.abspath(get_argv(2, "tempDir"))
projectName = "proj"
projectDir = os.path.join(workDir, projectName)
dbName = 'db'
dbDir = os.path.join(workDir, dbName)
outputName = get_argv(3, "stub")
outputFile = os.path.join(workDir, outputName + '.cs')
bqrsFile = os.path.join(workDir, outputName + '.bqrs')

print("\nCreating new project")
run_cmd(['dotnet', 'new', 'classlib', "--language", "C#", '--name',
         projectName, '--output', projectDir])

print("\nAdding reference")
run_cmd(['dotnet', 'add', projectDir, 'package', nuget])

print("\nCreating DB")
run_cmd(['codeql', 'database', 'create', dbDir, '--language=csharp',
         '--command', 'dotnet build /t:rebuild ' + projectDir])

if not os.path.isdir(dbDir):
    print("Expected database directory " + dbDir + " not found.")
    exit(1)

print("\nRunning query")
run_cmd(['codeql', 'query', 'run', os.path.join(
    thisDir, 'MinimalStubsFromSource.ql'), '--database', dbDir, '--output', bqrsFile])

run_cmd(['codeql', 'bqrs', 'decode', bqrsFile, '--output',
         outputFile, '--format=text', '--no-titles'])

# Remove the leading and trailing bytes from the file
length = os.stat(outputFile).st_size
if length < 20:
    contents = b''
else:
    f = open(outputFile, "rb")
    try:
        pre = f.read(2)
        print("Start characters in file skipped.", pre)
        contents = f.read(length - 5)
        post = f.read(3)
        print("End characters in file skipped.", post)
    finally:
        f.close()

f = open(outputFile, "wb")
f.write(contents)
f.close()

print("\nOutput: " + os.path.abspath(outputFile))
exit(0)
