// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

/// Same as Binary, but with 64-bit offsets, allowing to represent
/// extremely large data values.
internal struct LargeBinary : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_9(); }
  public static LargeBinary GetRootAsLargeBinary(ByteBuffer _bb) { return GetRootAsLargeBinary(_bb, new LargeBinary()); }
  public static LargeBinary GetRootAsLargeBinary(ByteBuffer _bb, LargeBinary obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LargeBinary __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartLargeBinary(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<LargeBinary> EndLargeBinary(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<LargeBinary>(o);
  }
}


static internal class LargeBinaryVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
