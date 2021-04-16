namespace Test
{
    public class Class1
    {
        public struct Struct1
        {
            public int i;
            public const int j = 42;

            public void Method(Struct1 s = new Struct1()) => throw null;
        }

        public interface Interface1
        {
            void Method1();
        }

        internal protected interface Interface2
        {
            void Method2();
            int this[int i] { get; }
        }

        private protected interface Interface3
        {
            void Method3();
        }

        public class Class11 : Interface1, Interface2, Interface3
        {
            public Class11(int i) => throw null;

            public void Method1() => throw null;

            void Interface2.Method2() => throw null;

            int Interface2.this[int i] => throw null;

            void Interface3.Method3() => throw null;
        }

        public delegate void Delegate1<T>(T i, int j);

        public event Delegate1<int> Event1 { add { } remove { } }

        public class Class12 : Class11
        {
            public Class12(int i, float j) : base(1) => throw null;
        }
    }

    internal class Class2
    {
        public void M() => throw null;
    }
}