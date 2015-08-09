using System.Linq;
using JetBrains.Annotations;
using PlayerIOClient;

namespace BotBits.SendMessages
{
    /// <summary>
    ///     Class Block Send Event
    /// </summary>
    public sealed class PurpleSwitchSendMessage : SendMessage<PurpleSwitchSendMessage>
    {
        public int SwitchId { get; set; }
        public int Enabled { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlaceSendMessage" /> class.
        /// </summary>
        public PurpleSwitchSendMessage(int switchId, int enabled)
        {
            this.SwitchId = switchId;
            this.Enabled = enabled;
        }


        /// <summary>
        ///     Gets the PlayerIO message representing the data in this <see cref="SendMessage{T}" />.
        /// </summary>
        /// <returns></returns>
        protected override Message GetMessage()
        {
            return Message.Create("ps", this.SwitchId, this.Enabled);
        }
    }
}