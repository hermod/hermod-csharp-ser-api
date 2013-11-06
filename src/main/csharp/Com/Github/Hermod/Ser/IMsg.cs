/*
 * Created by SharpDevelop.
 * User: Alexandre
 * Date: 03/11/2013
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Com.Github.Hermod.Ser
{
	/// <summary>
	/// Description of Msg.
	/// </summary>
  public interface IMsg
  {
    bool IsEmpty();

    bool IsBytesSerializable();

    //int[] GetKeysArray();
    int[] KeysArray
	{
	    get;
	}
        	
    //int GetKeyMax();
    int KeyMax
	{
	    get;
	}
       
    //int GetKeysLength();
    int KeysLength
	{
	    get;
	}

    Type GetType(uint i);

    byte GetTypeAsByte(uint i);

    bool IsArray(uint i);

    int GetArrayLength(uint i);

    bool Contains(uint i);

    Object Get(uint i);

    T Get<T>(uint i);

    bool GetAsBool(uint i);

    bool? GetAsNullableBool(uint i);

    byte GetAsByte(uint i);

    byte GetAsNullableByte(uint i);

    short GetAsShort(uint i);

    short? GetAsNullableShort(uint i);

    int GetAsInt(uint i);

    int? GetAsNullableInt(uint i);

    long GetAsLong(uint i);

    long? GetAsNullableLong(uint i);

    float GetAsFloat(uint i);

    float? GetAsNullableFloat(uint i);

    double GetAsDouble(uint i);

    double? GetAsNullableDouble(uint i);

    String GetAsString(uint i);

    IMsg GetAsIMsg(uint i);

    void GetAsIMsg(uint i, IMsg m);

    bool[] GetAsBools(uint i);

    bool?[] GetAsNullableBools(uint i);

    byte[] GetAsBytes(uint i);

    byte?[] GetAsNullableBytes(uint i);

    short[] GetAsShorts(uint i);

    short?[] GetAsNullableShorts(uint i);

    int[] GetAsInts(uint i);

    int?[] GetAsNullableInts(uint i);

    long[] GetAsLongs(uint i);

    long?[] GetAsNullableLongs(uint i);

    float[] GetAsFloats(uint i);

    float?[] GetAsNullableFloats(uint i);

    double[] GetAsDoubles(uint i);

    double?[] GetAsNullableDoubles(uint i);

    String[] GetAsStrings(uint i);

    IMsg[] GetAsIMsgs(uint i);

    void GetAsIMsgs(uint i, params IMsg[] marr);

    Object[] GetAsObjects(uint i);

    void GetAsObjects(uint i, params object[] objarr);

    IMsg GetAllAsIMsg();

    Object[] GetAllAsObjects();

    void GetAllAsObjects(params object[] objarr);
    
    void Set<T>(uint i, T t);

    void Set(uint i, Null n);

    void Set(uint i, Object obj);

    void Set(uint i, bool b);

    void Set(uint i, bool? b);

    void Set(int i, bool? b1, bool b2);

    void Set(uint i, byte b);

    void Set(uint i, byte? b);

    void Set(uint i, byte? b1, bool b2);

    void Set(uint i, short s);

    void Set(uint i, short s, bool b);

    void Set(uint i, short? s);

    void Set(uint i, short? s, bool b);

    void Set(uint i1, int i2);

    void Set(uint i1, int i2, bool b);

    void Set(uint i1, int? i2);

    void Set(uint i1, int? i2, bool b);

    void Set(uint i, long l);

    void Set(uint i, long l, bool b);

    void Set(uint i, long? l);

    void Set(uint i, long? l, bool b);

    void Set(uint i, float f);

    void Set(uint i, float? f);

    void Set(uint i, float? f, bool b);

    void Set(uint i, double d);

    void Set(uint i, double d, bool b);

    void Set(uint i, double? d);

    void Set(uint i, double? d, bool b);

    void Set(uint i1, double d, int i2);

    void Set(uint i1, double? d, int i2);

    void Set(uint i1, double? d, int i2, bool b);

    void Set(uint i, String str);

    void Set(uint i, String str, bool b);

    void Set(uint i, IMsg m);

    void Set(uint i, params bool[] barr);

    void Set(uint i, params bool?[] barr);

    void Set(uint i, params byte[] barr);

    void Set(uint i, params byte?[] barr);

    void Set(uint i, params short[] sarr);

    void Set(uint i, params short?[] sarr);

    void Set(uint i, params int[] iarr);

    void Set(uint i, params int?[] iarr);

    void Set(uint i, params long[] larr);

    void Set(uint i, params long?[] larr);

    void Set(uint i, params float[] farr);

    void Set(uint i, params float?[] farr);

    void Set(uint i, params double[] darr);

    void Set(uint i, params double?[] darr);

    void Set(uint i, params String[] strarr);

    void Set(uint i, String[] strarr, bool b);

    void Set(uint i, params IMsg[] marr);

    void SetAll(IMsg m);

    void SetAll(params object[] objarr);

    void Remove(params int[] iarr);

    void RemoveAll();
    
    
    // Indexer declaration: 
    //TODO is it correct
    Object this[int index]
    {
    	//TODO
       get;
       //set{Set(index, value)}
       set;
    }
	}
}
