using Microsoft.Toolkit.Uwp.Notifications;

namespace EmployeeActivityTracker.Utilities
{
    public static class Notification
    {
        public static void SendDataBaseError()
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9814)
                .AddText("Ошибка подключения БД")
                .AddText("Подключение к базе данных не настроено должным образом. Обратитесь к системному администратору.")
                .Show();
        }
        public static void SendMegaError()
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9814)
                .AddText("Ошибка импорта в Mega")
                .AddText("Импорт изображений в облачное хранилище не настроен должным образом. Обратитесь к системному администратору.")
                .Show();
        }
    }
}
