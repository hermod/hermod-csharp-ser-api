/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of IBytesMsgSerializer.
	/// </summary>
	public interface IBytesMsgSerializer : IMsgSerializer
	{
		byte[] SerializeToBytes(IMsg m);

    	int SerializeToBytes(IMsg m, byte[] barr, int i);

    	void DeserializeFromBytes(byte[] barr, int i1, int i2, IMsg m);
	}
}
