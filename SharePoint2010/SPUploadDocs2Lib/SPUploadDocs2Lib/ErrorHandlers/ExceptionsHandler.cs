using System;

namespace SPUploadDocs2Lib.ErrorHandlers
{
    public static class ExceptionsHandler
    {
        public static string HandleError(Exception ex)
        {
            return string.Format(@"{0}, {1}, {2}", ex.GetType(), ex.Message, ex.StackTrace);
        }
    }
}
