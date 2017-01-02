
namespace Homework_Defining_Classes_Part2.AttributesProject
{
    using System;
    using System.Text;

    [AttributeUsage (AttributeTargets.Class|
                         AttributeTargets.Struct|
                         AttributeTargets.Enum|
                         AttributeTargets.Interface|
                         AttributeTargets.Method,
                         AllowMultiple =false)]
    class VersionAttribute : Attribute
    {
        //Properties
        public string MajorVersion
        {
            get;
            private set;
        }

        public string MinorVersion
        {
            get;
            private set;
        }

        //Constructor
        public VersionAttribute(string majorVersion,string minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        //Override
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(string.Format($@"The version of the Software you use is: {this.MajorVersion}.{this.MinorVersion} version"));
            return sb.ToString();
        }
    }
}
