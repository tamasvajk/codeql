using System;
using System.Linq;

class SignAnalysis
{
    void Test1(bool b)
    {
        {
            int i = 0;
            System.Console.WriteLine(i);
        }
        {
            int i = 1 + 1;
            System.Console.WriteLine(i);
        }
        {
            int i = -1;
            System.Console.WriteLine(i);
        }
        {
            int i = 0;
            i++;
            System.Console.WriteLine(i);
        }
        {
            int i = 0;
            i--;
            System.Console.WriteLine(i);
        }
        {
            int i = 0;
            ++i;
            System.Console.WriteLine(i);
        }
        {
            int i = 0;
            --i;
            System.Console.WriteLine(i);
        }
        {
            int i = 0;
            --i;
            var j = i;
            System.Console.WriteLine(j);
        }
        {
            int i = 1;
            if (b)
            {
                i++;
            }
            System.Console.WriteLine(i);
        }
        {
            int i = 1;
            if (b)
            {
                i++;
            }
            else
            {
                i--;
            }
            System.Console.WriteLine(i);
        }
    }

    void Test2()
    {
        var i = 1;
        i = i * i;
        System.Console.WriteLine(i);
        i = i * -i;
        System.Console.WriteLine(i);
        i = -i * -i;
        System.Console.WriteLine(i);
        i = -i / -i;
        System.Console.WriteLine(i);
        i = -i % i;
        System.Console.WriteLine(i);
        i = -i;
        System.Console.WriteLine(i);
        i = +i;
        System.Console.WriteLine(i);
    }
    void Test3()
    {
        var f = 4.2f;
        System.Console.WriteLine(f);
        var d = 4.2;
        System.Console.WriteLine(d);
        var de = 4.2m;
        System.Console.WriteLine(de);
        var c = 'a';
        System.Console.WriteLine(c);
    }

    int f1;
    int f2 = 1;

    void TestField()
    {
        f1++;
        System.Console.WriteLine(f1);
        System.Console.WriteLine(f2);
        var j = f1;
        System.Console.WriteLine(j);
    }

    void Test4()
    {
        var i = new Int32();
        i++;
        System.Console.WriteLine(i);

        var ints = new int[] { 1, 2, 3 };
        System.Console.WriteLine(ints[0]);
    }

    int SomeValue() { return (new System.Random()).Next(0, 1000); }
    void Test5()
    {
        var i = SomeValue();
        if (i < 0)
        {
            System.Console.WriteLine(i);
            return;
        }

        System.Console.WriteLine(i); // positive, but not recognized

        if (i != 0)
        {
            System.Console.WriteLine(i); // strictly positive, but not recognized
        }
    }

    void Test5a()
    {
        var i = SomeValue();
        if (i == 1)
        {
            System.Console.WriteLine(i);
            return;
        }
    }

    void Test5b()
    {
        var i = SomeValue();
        if (i > 0)
        {
            System.Console.WriteLine(i);
            return;
        }
    }

    void Test6(int i)
    {
        if (i < 0)
        {
            System.Console.WriteLine(i);
        }
    }

    void Test7(int[] p)
    {
        var ints = p;
        System.Console.WriteLine(ints.Length); // positive
        ints = new int[] { 1, 2, 3 };
        System.Console.WriteLine(ints.Length); // 3, so strictly positive
        System.Console.WriteLine(ints.Count());
        System.Console.WriteLine(ints.Count(i => i > 1));

        var s = "abc";
        System.Console.WriteLine(s.Length);

        System.Console.WriteLine(int.MaxValue);
        System.Console.WriteLine(int.MinValue);
    }
}

// semmle-extractor-options: /r:System.Linq.dll