/* ������ ������ ������ � ��������� � ����������� � ����� ������ 
������� ��� ������ � ������ � ������ ��������, ��� ���������� ����������� ��������������� ������ ��������� */

// ������ � ������
IZennoList proxyList = project.Lists["proxyList"]; 

string proxy;

lock(SyncObjects.ListSyncer)
{
	string proxy = ProxyList[0];
	ProxyList.RemoveAt(0);
	ProxyList.Add(proxy);
}

// �������� proxy �� ������ � ���������� �������
project.Variables["proxy"].Value = proxy;


	