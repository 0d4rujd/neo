namespace AntShares.Network.Payloads
{
    internal static class Helper
    {
        public static string GetCommandName(this InventoryType type)
        {
            //TODO: ��ʱ����ö�����ƣ�δ�����ܻ���ö���������������Ʋ�һ�µ��������Ҫ��������
            return type.ToString().ToLower();
        }
    }
}
