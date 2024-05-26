using YGate.Shared.Concretes;

namespace YGate.Server
{
    public static class LoginTokens
    {
        public static List<ProcessToken> Tokens { get; private set; } = new List<ProcessToken>();

        public static bool AddToken(ProcessToken addedToken) {
			try
			{
                Tokens.Add(addedToken);
                return true;
            }
			catch (Exception)
			{
                return false;
			}
        }

        public static bool ControlToken(string Token)
        {
            var token = Tokens.FirstOrDefault(xd => xd.Token == Token);
            if (token.ValidTime > DateTime.Now)
                return true;
            else
            {
                Tokens.Remove(token);
                return false;
            }
        }

        public static bool ControlToken(ProcessToken Token)
        {
            return ControlToken(Token.Token);
        }
    }
}
