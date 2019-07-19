namespace EncryptedChat.Client.App
{
    public static class Messages
    {
        public const string ConnectingToServer = "Connecting to {0}...";
        public const string Connected = "Connected.";
        public const string Disconnected = "Disconnected.";
        public const string UsernamePrompt = "Username: ";
        public const string InvalidUserIdSelectedError = "Please type a number from 0 to {0}";
        public const string GeneratingSessionKey = "Generating session key...";
        public const string InitialisingEncryptedConnection = "Initialising encrypted connection...";
        public const string ConnectedWithUser = "Connected with {0}!";
        public const string UserListHeader = "Users:";
        public const string UserListItem = "{0} - {1}";
        public const string UserListJoin = "Join";
        public const string UserListNoUsers = "None";
        public const string GeneratingKeyPair = "Generating keypair...";
        public const string SendingKeyToServer = "Sending public key to server...";
        public const string WaitingForUser = "Waiting for other user";
        public const string KeyFingerprint = "Fingerprint: {0}";
        public const string MessageFormat = "<{0}> {1}";
    }
}