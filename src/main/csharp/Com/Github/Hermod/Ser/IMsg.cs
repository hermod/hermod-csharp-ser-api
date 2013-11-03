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

    int[] GetKeysArray();

    int GetKeyMax();

    int GetKeysLength();

    Type GetType(int i);

    byte GetTypeAsByte(int i);

    bool IsArray(int i);

    int GetArrayLength(int i);

    bool Contains(int i);

    Object Get(int i);

    T Get<T>(int i);

    bool GetAsBool(int i);

    bool? GetAsNullableBool(int i);

    byte GetAsByte(int i);

    byte? GetAsNullableByte(int i);

    short GetAsShort(int i);

    short? GetAsNullableShort(int i);

    int GetAsInt(int i);

    int? GetAsNullableInt(int i);

    long GetAsLong(int i);

    long? GetAsNullableLong(int i);

    float GetAsFloat(int i);

    float? GetAsNullableFloat(int i);

    double GetAsDouble(int i);

    double? GetAsNullableDouble(int i);

    string GetAsString(int i);

    IMsg GetAsIMsg(int i);

    void GetAsIMsg(int i, IMsg m);

    bool[] GetAsBools(int i);

    bool?[] GetAsNullableBools(int i);

    byte[] GetAsBytes(int i);

    byte?[] GetAsNullableBytes(int i);

    short[] GetAsShorts(int i);

    short?[] GetAsNullableShorts(int i);

    int[] GetAsInts(int i);

    int?[] GetAsNullableInts(int i);

    long[] GetAsLongs(int i);

    long?[] GetAsNullableLongs(int i);

    float[] GetAsFloats(int i);

    float?[] GetAsNullableFloats(int i);

    double[] GetAsDoubles(int i);

    double?[] GetAsNullableDoubles(int i);

    string[] GetAsStrings(int i);

    IMsg[] GetAsIMsgs(int i);

    void GetAsIMsgs(int i, params IMsg[] marr);

    object[] GetAsObjects(int i);

    void GetAsObjects(int i, params object[] objarr);

    IMsg GetAllAsIMsg();

    object[] GetAllAsObjects();

    void GetAllAsObjects(params object[] objarr);

    void Set(int i, Null n);

    void Set(int i, object obj);

    void Set(int i, bool b);

    void Set(int i, bool? b);

    void Set(int i, Boolean b1, bool b2);

    void Set(int i, byte b);

    void Set(int i, byte? b);

    void Set(int i, byte? b1, bool b2);

    void Set(int i, short s);

    void Set(int i, short s, bool b);

    void Set(int i, short? s);

    void Set(int i, short? s, bool b);

    void Set(int i1, int i2);

    void Set(int i1, int i2, bool b);

    void Set(int i1, int? i2);

    void Set(int i1, int? i2, bool b);

    void Set(int i, long l);

    void Set(int i, long l, bool b);

    void Set(int i, long? l);

    void Set(int i, long? l, bool b);

    void Set(int i, float f);

    void Set(int i, float? f);

    void Set(int i, float? f, bool b);

    void Set(int i, double d);

    void Set(int i, double d, bool b);

    void Set(int i, double? d);

    void Set(int i, double? d, bool b);

    void Set(int i1, double d, int i2);

    void Set(int i1, double? d, int i2);

    void Set(int i1, double? d, int i2, bool b);

    void Set(int i, string str);

    void Set(int i, string str, bool b);

    void Set(int i, IMsg m);

    void Set(int i, params bool[] barr);

    void Set(int i, params bool?[] barr);

    void Set(int i, params byte[] barr);

    void Set(int i, params byte?[] barr);

    void Set(int i, params short[] sarr);

    void Set(int i, params short?[] sarr);

    void Set(int i, params int[] iarr);

    void Set(int i, params int?[] iarr);

    void Set(int i, params long[] larr);

    void Set(int i, params long?[] larr);

    void Set(int i, params float[] farr);

    void Set(int i, params float?[] farr);

    void Set(int i, params double[] darr);

    void Set(int i, params double?[] darr);

    void Set(int i, params string[] strarr);

    void Set(int i, string[] strarr, bool b);

    void Set(int i, params IMsg[] marr);

    void SetAll(IMsg m);

    void SetAll(params object[] objarr);

    void Remove(params int[] iarr);

    void RemoveAll();
    
    
    // Indexer declaration: 
    //TODO is it correct
    Object this[int index]
    {
       get;
       set;
    }
       
	}
}
