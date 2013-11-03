/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of Type.
	/// </summary>
	public enum Type
	{
		NULL = Types.NULL_TYPE,
		SKIPPED_KEYS_TYPE = Types.SKIPPED_KEYS_TYPE,
		INTEGER = Types.INTEGER_TYPE,
		DECIMAL = Types.DECIMAL_TYPE,
		STRING_UTF8 = Types.STRING_UTF_8_TYPE,
		MSG = Types.MSG_TYPE,
		ARRAY_FIXED_VALUE = Types.ARRAY_FIXED_VALUE_TYPE,
		ARRAY_VARIABLE_VALUE = Types.ARRAY_VARIABLE_VALUE_TYPE
	}
}
