﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
	public class Service1 : IService1
    {
		public Album Albums (int id)
		{
			// fake some data
			var tracks = new Track[] {
				new Track { Title = "The Miracle (of Joey Ramone)", Length = 255 },
				new Track { Title = "Every Breaking Wave", Length = 252 }
			};

			var album = new Album {
				Artist = "U2",
				Tracks = tracks
			};

			return album;
		}

		public string SayHello (string name)
		{
			if (name != null) {
				return string.Format ("Hello, {0}!", name);
			} else {
				return "Hello!";
			}
		}

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}