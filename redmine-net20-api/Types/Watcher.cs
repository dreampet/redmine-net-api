﻿/*
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
    [XmlRoot(RedmineKeys.USER)]
	public class Watcher : IdentifiableName, IValue, ICloneable
    {
		#region IValue implementation

		public string Value {
			get {
				return Id.ToString();
			}
		}

		#endregion

		public override string ToString ()
		{
			return string.Format ("[Watcher: {0}]", base.ToString());
		}

		public object Clone()
		{
			var watcher = new Watcher{Id = Id, Name = Name};
			return watcher;
		}
    }
}