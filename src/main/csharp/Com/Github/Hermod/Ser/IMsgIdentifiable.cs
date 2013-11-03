/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of MsgIdentifiable.
	/// </summary>
	public interface IMsgIdentifiable
	{
		
		//int getMsgId();
    	//void setMsgId(int i);
    	
    	int MsgId
	    {
	        get;
	        set;
	    }
	}
}
