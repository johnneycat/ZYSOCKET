﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "String");
            this._serializer0.PackTo(packer, objectTree.String);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor);
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string ctorArg0 = default(string);
                ctorArg0 = null;
                string nullable = default(string);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor), "System.String String");
                }
                if (((nullable == null) 
                            == false)) {
                    ctorArg0 = nullable;
                }
                unpacked = (unpacked + 1);
                result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor(ctorArg0);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string ctorArg00 = default(string);
                ctorArg00 = null;
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "String")) {
                        string nullable1 = default(string);
                        nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor), "System.String String");
                        if (((nullable1 == null) 
                                    == false)) {
                            ctorArg00 = nullable1;
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
                result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Normal_StringGetOnlyPropertyAndConstructor(ctorArg00);
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
