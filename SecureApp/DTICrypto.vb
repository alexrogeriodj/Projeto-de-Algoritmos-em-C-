Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class DTICrypto

    Public Function Decifrar(ByVal vstrStringToBeDecrypted As String, ByVal vstrDecryptionKey As String) As String

        Dim bytDataToBeDecrypted() As Byte
        Dim bytTemp() As Byte
        Dim bytIV() As Byte = {122, 10, 15, 77, 131, 71, 21, 59, 255, 81, 5, 7, 14, 209, 24, 111}
        Dim objRijndaelManaged As New RijndaelManaged
        Dim objMemoryStream As MemoryStream
        Dim objCryptoStream As CryptoStream
        Dim bytDecryptionKey() As Byte
        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim intCtr As Integer
        Dim strReturnString As String = String.Empty
        Dim achrCharacterArray() As Char
        Dim intIndex As Integer

        ' Converte de base64 cifrada para array de bytes
        bytDataToBeDecrypted = Convert.FromBase64String(vstrStringToBeDecrypted)

        ' A chave gerada será de 256 bits long (32 bytes) 
        ' Se for maior que 32 bytes, então vamos truncar;
        ' Se for menor que 32 bytes, vamos alocar para atingir 256 bits.  
        intLength = Len(vstrDecryptionKey)

        If intLength >= 32 Then
            vstrDecryptionKey = Strings.Left(vstrDecryptionKey, 32)
        Else
            intLength = Len(vstrDecryptionKey)
            intRemaining = 32 - intLength
            vstrDecryptionKey = vstrDecryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytDecryptionKey = Encoding.ASCII.GetBytes(vstrDecryptionKey.ToCharArray)

        ReDim bytTemp(bytDataToBeDecrypted.Length)

        objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

        ' Escreve o valor descriptografado após a conversão
        Try
            objCryptoStream = New CryptoStream(objMemoryStream, _
            objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV), _
            CryptoStreamMode.Read)

            objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

            objCryptoStream.FlushFinalBlock()
            objMemoryStream.Close()
            objCryptoStream.Close()

        Catch

        End Try

        ' Retorna o valor descriptografado
        Return TiraCaracteresNulos(Encoding.ASCII.GetString(bytTemp))

    End Function

    Private Function TiraCaracteresNulos(ByVal vstrStringWithNulls As String) As String

        Dim intPosition As Integer
        Dim strStringWithOutNulls As String

        intPosition = 1
        strStringWithOutNulls = vstrStringWithNulls

        Do While intPosition > 0
            intPosition = InStr(intPosition, vstrStringWithNulls, vbNullChar)

            If intPosition > 0 Then
                strStringWithOutNulls = Left$(strStringWithOutNulls, intPosition - 1) & _
                Right$(strStringWithOutNulls, Len(strStringWithOutNulls) - intPosition)
            End If

            If intPosition > strStringWithOutNulls.Length Then
                Exit Do
            End If
        Loop

        Return strStringWithOutNulls

    End Function

End Class
