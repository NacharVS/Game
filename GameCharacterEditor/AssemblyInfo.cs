using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// ����� �������� �� ���� ������ ��������������� ��������� �������
// ����� ���������. �������� �������� ���� ���������, ����� �������� ��������,
// ��������� �� �������.
[assembly: AssemblyTitle("Game")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Game")]
[assembly: AssemblyCopyright("Copyright �  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ��������� �������� False ��� ��������� ComVisible ������ ���� � ���� ������ ����������
// ��� ����������� COM. ���� ���������� ���������� � ���� � ���� ������ �����
// �� ������ COM, ���������� ������� ComVisible ��� ����� ���� � �������� true.
[assembly: ComVisible(false)]

//����� ������ �������� ������������ ����������, �������
//<UICulture>CultureYouAreCodingWith</UICulture> � ����� .csproj
//� <PropertyGroup>. ��������, ��� ������������� ����������� (���)
//� ����� �������� ������ ���������� <UICulture> � en-US.  ����� �������� �������������� � �����������
//�������� NeutralResourceLanguage ����.  �������� "en-US" �
//������ ����� ��� ����������� ������������ ��������� UICulture � ����� �������.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //��� ����������� ������� �������� �� ���������� ���������
                                     //(������������, ���� ������ �� ������ �� ��������,
                                     // ��� � �������� �������� ����������)
    ResourceDictionaryLocation.SourceAssembly //��� ���������� ������� ������������� ��������
                                              //(������������, ���� ������ �� ������ �� ��������,
                                              // � ���������� ��� � �����-���� �������� �������� ��� ���������� ����)
)]


// �������� � ������ ��� ������ �������� ������ ��������� ��������:
//
//      �������� ����� ������
//      �������������� ����� ������
//      ����� ������
//      ����� ��������
//
// ����� ������ ��� �������� ��� ������� ������ ������ � �������� �� ��������� 
// ��������� "*", ��� �������� ����:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
