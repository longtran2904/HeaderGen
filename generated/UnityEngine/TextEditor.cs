#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    public class TextEditor
    {

        public TouchScreenKeyboard keyboardOnScreen;
        public int controlID;
        public GUIStyle style;
        public bool multiline;
        public bool hasHorizontalCursorPos;
        public bool isPasswordField;
        public Vector2 scrollOffset;
        public Vector2 graphicalCursorPos;
        public Vector2 graphicalSelectCursorPos;

        [RequiredByNativeCode]
        public TextEditor();

        [Obsolete("Please use 'text' instead of 'content'", False)]
        public GUIContent content { get; set; }
        public string text { get; set; }
        public Rect position { get; set; }
        public int cursorIndex { get; set; }
        public int selectIndex { get; set; }
        public DblClickSnapping doubleClickSnapping { get; set; }
        public int altCursorPosition { get; set; }
        public bool hasSelection { get; }
        public string SelectedText { get; }

        public void OnFocus();
        public void OnLostFocus();
        public bool HandleKeyEvent(Event e);
        public bool DeleteLineBack();
        public bool DeleteWordBack();
        public bool DeleteWordForward();
        public bool Delete();
        public bool CanPaste();
        public bool Backspace();
        public void SelectAll();
        public void SelectNone();
        public bool DeleteSelection();
        public void ReplaceSelection(string replace);
        public void Insert(char c);
        public void MoveSelectionToAltCursor();
        public void MoveRight();
        public void MoveLeft();
        public void MoveUp();
        public void MoveDown();
        public void MoveLineStart();
        public void MoveLineEnd();
        public void MoveGraphicalLineStart();
        public void MoveGraphicalLineEnd();
        public void MoveTextStart();
        public void MoveTextEnd();
        public void MoveParagraphForward();
        public void MoveParagraphBackward();
        public void MoveCursorToPosition(Vector2 cursorPosition);
        protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift);
        public void MoveAltCursorToPosition(Vector2 cursorPosition);
        public bool IsOverSelection(Vector2 cursorPosition);
        public void SelectToPosition(Vector2 cursorPosition);
        public void SelectLeft();
        public void SelectRight();
        public void SelectUp();
        public void SelectDown();
        public void SelectTextEnd();
        public void SelectTextStart();
        public void MouseDragSelectsWholeWords(bool on);
        public void DblClickSnap(DblClickSnapping snapping);
        public void MoveWordRight();
        public void MoveToStartOfNextWord();
        public void MoveToEndOfPreviousWord();
        public void SelectToStartOfNextWord();
        public void SelectToEndOfPreviousWord();
        public int FindStartOfNextWord(int p);
        public void MoveWordLeft();
        public void SelectWordRight();
        public void SelectWordLeft();
        public void ExpandSelectGraphicalLineStart();
        public void ExpandSelectGraphicalLineEnd();
        public void SelectGraphicalLineStart();
        public void SelectGraphicalLineEnd();
        public void SelectParagraphForward();
        public void SelectParagraphBackward();
        public void SelectCurrentWord();
        public void SelectCurrentParagraph();
        public void UpdateScrollOffsetIfNeeded(Event evt);
        public void DrawCursor(string newText);
        public void SaveBackup();
        public void Undo();
        public bool Cut();
        public void Copy();
        public bool Paste();
        public void DetectFocusChange();
        public enum DblClickSnapping
        {

            WORDS = 0,
            PARAGRAPHS = 1
        }
    }
}
