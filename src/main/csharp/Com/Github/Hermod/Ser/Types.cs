/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of Types.
	/// </summary>
	public class Types
	{
		public const byte NULL_TYPE = (byte) 0;
    	public const byte SKIPPED_KEYS_TYPE = (byte) 0;
    	public const byte INTEGER_TYPE = (byte) 64;
    	public const byte DECIMAL_TYPE = (byte) 96;
    	public const byte STRING_UTF_8_TYPE = (byte) 128;
    	public const string UTF_8_CHARSET_NAME = "UTF-8";
    	public const byte MSG_TYPE = (byte) 160;
    	public const byte ARRAY_FIXED_VALUE_TYPE = (byte) 192;
    	public const byte ARRAY_VARIABLE_VALUE_TYPE = (byte) 224;
    	public const byte TYPE_MASK = (byte) 224;
    	
	}
}
