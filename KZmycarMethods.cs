using System.Reflection;
using UnityEngine; 

namespace Oxide.Plugins
{
    [Info("KZmycarMethods", "KzFAL", "1.0.0")]
    public class KZmycarMethods : RustPlugin
    {
        [ChatCommand("mycar")]
        private void CmdListApi(BasePlayer player, string command, string[] args)
        {
            
            player.ChatMessage("All ModularCar methods and fields have been output to the server console. It is recommended to delete this plugin after use to prevent others from spamming it.");
            player.ChatMessage("Все методы и поля ModularCar выведены в консоль сервера. Рекомендуется удалить плагин после использования, так как он доступен всем и его могут заспамить.");

            // Методы
            Debug.Log("[car] ========== MODULAR CAR METHODS ==========");
            foreach (var m in typeof(ModularCar).GetMethods(
                         BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                Debug.Log("[car] " + m.Name);

            // Поля
            Debug.Log("[car] ========== MODULAR CAR FIELDS ==========");
            foreach (var f in typeof(ModularCar).GetFields(
                         BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                Debug.Log("[car] " + f.Name);
        }
    }
}