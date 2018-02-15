
namespace Microsoft.BusinessData.Runtime
{
    public class EntityInstanceMock : EntityInstance
    {


        public override System.Collections.Generic.Dictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.Object Item => ItemEx;
        public System.Object ItemEx { get; set; }

    }
}

