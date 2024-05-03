using Editor;

public static class MyEditorMenu
{
	[Menu( "Editor", "Kicks' component collection/My Menu Option" )]
	public static void OpenMyMenu()
	{
		EditorUtility.DisplayDialog( "It worked!", "This is being called from your library's editor code!" );
	}
}
