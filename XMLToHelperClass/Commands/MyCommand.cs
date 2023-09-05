using Microsoft.VisualStudio.TextManager.Interop;
using System.Windows;

namespace XMLToHelperClass
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand> 
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            var doc =await VS.Documents.GetActiveDocumentViewAsync();

            Clipboard.SetText(doc.TextBuffer.CurrentSnapshot.GetText());

        }
    }
}
