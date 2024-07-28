﻿
#nullable enable
namespace Serde.Test;
partial struct MaxSizeType : Serde.ISerdeInfoProvider
{
    static global::Serde.ISerdeInfo global::Serde.ISerdeInfoProvider.SerdeInfo { get; } = Serde.SerdeInfo.MakeCustom(
        "MaxSizeType",
        typeof(Serde.Test.MaxSizeType).GetCustomAttributesData(),
        new (string, global::Serde.ISerdeInfo, System.Reflection.MemberInfo)[] {
("field1", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field1")!),
("field2", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field2")!),
("field3", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field3")!),
("field4", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field4")!),
("field5", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field5")!),
("field6", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field6")!),
("field7", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field7")!),
("field8", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field8")!),
("field9", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field9")!),
("field10", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field10")!),
("field11", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field11")!),
("field12", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field12")!),
("field13", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field13")!),
("field14", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field14")!),
("field15", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field15")!),
("field16", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field16")!),
("field17", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field17")!),
("field18", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field18")!),
("field19", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field19")!),
("field20", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field20")!),
("field21", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field21")!),
("field22", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field22")!),
("field23", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field23")!),
("field24", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field24")!),
("field25", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field25")!),
("field26", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field26")!),
("field27", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field27")!),
("field28", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field28")!),
("field29", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field29")!),
("field30", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field30")!),
("field31", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field31")!),
("field32", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field32")!),
("field33", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field33")!),
("field34", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field34")!),
("field35", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field35")!),
("field36", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field36")!),
("field37", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field37")!),
("field38", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field38")!),
("field39", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field39")!),
("field40", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field40")!),
("field41", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field41")!),
("field42", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field42")!),
("field43", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field43")!),
("field44", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field44")!),
("field45", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field45")!),
("field46", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field46")!),
("field47", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field47")!),
("field48", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field48")!),
("field49", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field49")!),
("field50", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field50")!),
("field51", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field51")!),
("field52", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field52")!),
("field53", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field53")!),
("field54", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field54")!),
("field55", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field55")!),
("field56", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field56")!),
("field57", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field57")!),
("field58", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field58")!),
("field59", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field59")!),
("field60", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field60")!),
("field61", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field61")!),
("field62", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field62")!),
("field63", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field63")!),
("field64", global::Serde.SerdeInfoProvider.GetInfo<global::Serde.ByteWrap>(), typeof(Serde.Test.MaxSizeType).GetProperty("Field64")!)
    });
}