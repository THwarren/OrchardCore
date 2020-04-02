namespace OrchardCore.Data.Documents
{
    public abstract class BaseDocument : IDocument
    {
        /// <summary>
        /// The <see cref="IDocument.Identifier"/>.
        /// </summary>
        public string Identifier { get; set; }
    }
}