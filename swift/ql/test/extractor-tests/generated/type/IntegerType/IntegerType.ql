// generated by codegen/codegen.py, do not edit
import codeql.swift.elements
import TestUtils

from IntegerType x, string getName, Type getCanonicalType, string getValue
where
  toBeTested(x) and
  not x.isUnknown() and
  getName = x.getName() and
  getCanonicalType = x.getCanonicalType() and
  getValue = x.getValue()
select x, "getName:", getName, "getCanonicalType:", getCanonicalType, "getValue:", getValue
