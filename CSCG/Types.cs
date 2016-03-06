namespace CSCG
{
    public enum ViewState
    {
        Project,
        Namespace,

    }
    public enum NodeType
    {
        Root,
        Namespace,
        Class,
        Interface,
        Abstract,
        Constructor,
        Field,
        Property,
        Method
    }
    public enum Accessibility
    {
        Public,
        Private,
        Protected,
        Internal,
        ProtectedInternal,
        None
    }
}
