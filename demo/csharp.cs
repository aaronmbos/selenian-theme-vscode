using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenian
{
    public class CSharp
    {
        private const int TestConst = 1;
        private readonly int? _nullable = null;
        private readonly string _testField;

        public string TestProperty { get; set; }

        #region RegionTest
        public string Getter => TestProperty;

        public CSharp(string testField)
        {
            _testField = testField;
            string text = $"{TestProperty} this is a text string";
            int number = 1;
            this.TestProperty = "";
        }

        #endregion

        /// <summary>
        /// Hello this is an xml comment
        /// </summary>
        /// <param name="testParam">param comment</param>
        /// <returns></returns>
        public async Task<string> TestMethod(string testParam)
        {
            var test = new List<string>();
            for (var i = 0; i <= 5; i++)
            {
                testParam.Trim();
                _testField?.Trim();

                var enumVal = (int)TestEnum.TestValue;

                // Hello this is a normal comment
                new List<string>().Where(c => c == "Test");
            }

            return await Task.FromResult(testParam);
        }
    }

    public enum TestEnum
    {
        TestValue
    }
}