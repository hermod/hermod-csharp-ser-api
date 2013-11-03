/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of BytesSerializable.
	/// </summary>
	public interface IBytesSerializable : Com.Github.Hermod.Ser.ISerializable
	{
		byte[] SerializeToBytes();

    	int SerializeToBytes(byte[] barr, int i);

    	void DeserializeFromBytes(byte[] barr, int i1, int i2);
	}
}
