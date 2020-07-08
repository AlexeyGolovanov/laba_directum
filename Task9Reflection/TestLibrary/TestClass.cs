namespace TestLibrary
{
    using System;
    public class TestClass
    {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }

        public readonly int IntReadOnly;

        private string PrivateString;

        [Obsolete]
        public string ObsoleteString { get; set; }

        [Obsolete]
        public TestClass()
        {
            IntProperty = 1;
            StringProperty = "example text 1";
            IntReadOnly = 1;
            PrivateString = "private string 1";
            ObsoleteString = "obsolete example 1";
        }
    }
}
