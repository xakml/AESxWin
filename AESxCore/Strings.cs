using System;
using System.Collections.Generic;
using System.Text;

namespace AESxCore
{
    /// <summary>
    /// Placeholder for translateable strings
    /// </summary>
    public static class Strings
    {
        #region Command line
        /// <summary>
        /// A string displayed when the program is invoked without the correct number of arguments
        /// </summary>
        public static string CommandlineUsage = "SharpAESCrypt e|d password fromPath toPath";
        /// <summary>
        /// A string displayed when an error occurs while running the commandline program
        /// </summary>
        public static string CommandlineError = "Error: {0}";
        /// <summary>
        /// A string displayed if the mode is neither e nor d 
        /// </summary>
        public static string CommandlineUnknownMode = "Invalid operation, must be (e)crypt or (d)ecrypt";
        #endregion

        #region Exception messages
        /// <summary>
        /// An exception message that indicates that the hash algorithm is not supported
        /// </summary>
        public static string UnsupportedHashAlgorithmReuse = "The hash algortihm does not support reuse";
        /// <summary>
        /// An exception message that indicates that the hash algorithm is not supported
        /// </summary>
        public static string UnsupportedHashAlgorithmBlocks = "The hash algortihm does not support multiple blocks";
        /// <summary>
        /// An exception message that indicates that the hash algorithm is not supported
        /// </summary>
        public static string UnsupportedHashAlgorithmBlocksize = "Unable to digest {0} bytes, as the hash algorithm only returns {1} bytes";
        /// <summary>
        /// An exception message that indicates that an unexpected end of stream was encountered
        /// </summary>
        public static string UnexpectedEndOfStream = "The stream was exhausted unexpectedly";
        /// <summary>
        /// An exception message that indicates that the stream does not support writing
        /// </summary>
        public static string StreamMustBeWriteAble = "When encrypting, the stream must be writeable";
        /// <summary>
        /// An exception messaget that indicates that the stream does not support reading
        /// </summary>
        public static string StreamMustBeReadAble = "When decrypting, the stream must be readable";
        /// <summary>
        /// An exception message that indicates that the mode is not one of the allowed enumerations
        /// </summary>
        public static string InvalidOperationMode = "Invalid mode supplied";

        /// <summary>
        /// An exception message that indicates that file is not in the correct format
        /// </summary>
        public static string InvalidFileFormat = "Invalid file format";
        /// <summary>
        /// An exception message that indicates that the header marker is invalid
        /// </summary>
        public static string InvalidHeaderMarker = "Invalid header marker";
        /// <summary>
        /// An exception message that indicates that the reserved field is not set to zero
        /// </summary>
        public static string InvalidReservedFieldValue = "Reserved field is not zero";
        /// <summary>
        /// An exception message that indicates that the detected file version is not supported
        /// </summary>
        public static string UnsupportedFileVersion = "Unsuported file version: {0}";
        /// <summary>
        /// An exception message that indicates that an extension had an invalid format
        /// </summary>
        public static string InvalidExtensionData = "Invalid extension data, separator (0x00) not found";
        /// <summary>
        /// An exception message that indicates that the format was accepted, but the password was not verified
        /// </summary>
        public static string InvalidPassword = "Invalid password or corrupted data";
        /// <summary>
        /// An exception message that indicates that the length of the file is incorrect
        /// </summary>
        public static string InvalidFileLength = "File length is invalid";

        /// <summary>
        /// An exception message that indicates that the version is readonly when decrypting
        /// </summary>
        public static string VersionReadonlyForDecryption = "Version is readonly when decrypting";
        /// <summary>
        /// An exception message that indicates that the file version is readonly once encryption has started
        /// </summary>
        public static string VersionReadonly = "Version cannot be changed after encryption has started";
        /// <summary>
        /// An exception message that indicates that the supplied version number is unsupported
        /// </summary>
        public static string VersionUnsupported = "The maximum allowed version is {0}";
        /// <summary>
        /// An exception message that indicates that the stream must support seeking
        /// </summary>
        public static string StreamMustSupportSeeking = "The stream must be seekable writing version 0 files";

        /// <summary>
        /// An exception message that indicates that the requsted operation is unsupported
        /// </summary>
        public static string CannotReadWhileEncrypting = "Cannot read while encrypting";
        /// <summary>
        /// An exception message that indicates that the requsted operation is unsupported
        /// </summary>
        public static string CannotWriteWhileDecrypting = "Cannot read while decrypting";

        /// <summary>
        /// An exception message that indicates that the data has been altered
        /// </summary>
        public static string DataHMACMismatch = "Message has been altered, do not trust content";
        /// <summary>
        /// An exception message that indicates that the data has been altered or the password is invalid
        /// </summary>
        public static string DataHMACMismatch_v0 = "Invalid password or content has been altered";

        /// <summary>
        /// An exception message that indicates that the system is missing a text encoding
        /// </summary>
        public static string EncodingNotSupported = "The required encoding (UTF-16LE) is not supported on this system";
        #endregion
    }
}
