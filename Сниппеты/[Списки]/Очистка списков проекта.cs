/* ������� ������� ������� */

// ����� ������� �������
List<string> outlist = new List<string> { "SourceList1", "SourceList2", "SourceList3", "SourceList4", "SourceList5",
                                          "SourceList6", "SourceList7", "SourceList8", "SourceList9", "SourceList10" };
foreach (string str in outlist) {
    project.Lists[""+str+""].Clear();
}
