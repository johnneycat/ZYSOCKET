﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_ObjectModel_ObservableCollection_1_System_Int32_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<System.Collections.ObjectModel.ObservableCollection<int>, int> {
        
        public System_Collections_ObjectModel_ObservableCollection_1_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_ObjectModel_ObservableCollection_1_System_Int32_Serializer.RestoreSchema()) {
        }
        
        protected override System.Collections.ObjectModel.ObservableCollection<int> CreateInstance(int initialCapacity) {
            System.Collections.ObjectModel.ObservableCollection<int> collection = default(System.Collections.ObjectModel.ObservableCollection<int>);
            collection = new System.Collections.ObjectModel.ObservableCollection<int>();
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
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
