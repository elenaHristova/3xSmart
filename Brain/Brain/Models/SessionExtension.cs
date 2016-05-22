using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public static class SessionExtension
	{
		public static T GetSession<T>(this HttpSessionStateBase session, string key)
		{
			return (T)session[key];
		}
		public static void SetSession<T>(this HttpSessionStateBase session, string key, object value)
		{
			session[key] = value;
		}
	}
}