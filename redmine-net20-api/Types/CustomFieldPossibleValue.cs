/*
   Copyright 2011 - 2016 Adrian Popescu.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Xml.Serialization;

namespace Redmine.Net.Api.Types
{
    [XmlRoot(RedmineKeys.POSSIBLE_VALUE)]
    public class CustomFieldPossibleValue : IEquatable<CustomFieldPossibleValue>
    {
        [XmlElement(RedmineKeys.VALUE)]
        public string Value { get; set; }

        public bool Equals(CustomFieldPossibleValue other)
        {
            if (other == null) return false;
            return (Value == other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as CustomFieldPossibleValue);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = 13;
				hashCode = Value.GetHashCode(hashCode);
                return hashCode;
            }
        }

		public override string ToString ()
		{
			return string.Format ("[CustomFieldPossibleValue: {0}]", base.ToString());
		}
    }
}