namespace Exercise2_1
{
    public class FunctionalDependency
    {
        public FunctionalDependency(string lhs, string rhs)
        {
            LeftHandSide = new AttributeList(lhs);
            RightHandSide = new AttributeList(rhs);
        }

        public AttributeList LeftHandSide { get; }
        public AttributeList RightHandSide { get; }

        public override string ToString()
        {
            return $"{{{LeftHandSide}}} -> {{{RightHandSide}}}";
        }
    }
}