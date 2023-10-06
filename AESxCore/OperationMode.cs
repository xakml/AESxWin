using System;

namespace SharpAESCrypt.Core
{
    /// <summary>
    /// Enumerates the possible modes for encryption and decryption
    /// </summary>
    public enum OperationMode
    {
        /// <summary>
        /// Indicates encryption, which means that the stream must be writeable
        /// </summary>
        Encrypt,
        /// <summary>
        /// Indicates decryption, which means that the stream must be readable
        /// </summary>
        Decrypt
    }
}
