'-----------------------------------------------------------------------
' Title:    GISC9304-Assignment 2 – VB .NET Application Development
' Author:   Travis Vanos
' Date:     11/11/2015
' Purpose:  .NET Mapping Scale calculator with data validation 
' ----------------------------------------------------------------------
Option Strict On

Module consoleAerialCameraConversion
    Sub Main()

        Dim strFocalLength As String = ""
        Dim doubleFocalLength As Double
        Dim strHeight As Integer
        Dim doubleHeight As Double
        Dim intElevation As Integer
        Dim intSum As Integer
        Dim LoopValidation As Boolean = False

        Console.Write("---------------------------------------------------------------" & vbCrLf)
        Console.Write("Travis Vanos' Map Scale Program V 1.0" & vbCrLf)
        Console.Write("---------------------------------------------------------------" & vbCrLf & vbCrLf & vbCrLf)

        Do While 

            Console.Write("Please enter the focal length (f) of the aerial camera (in centimetre) " & vbCrLf)
            strFocalLength = Console.ReadLine()

            Do While LoopValidation = False
                If Double.TryParse(strFocalLength, doubleFocalLength) And doubleFocalLength > 0.1 And doubleFocalLength < 99.9 Then
                    doubleFocalLength = System.Convert.ToDecimal(strFocalLength)
                    LoopValidation = True
                Else
                    Console.Write("-------------------------------------------------------------" & vbCrLf)
                    Console.Write("| Error! Please Valid Numeric Value from 0.1 to 99.9         |" & vbCrLf)
                    Console.Write("-------------------------------------------------------------" & vbCrLf & vbCrLf)
                    Console.Write("Press any key to continue . . . ")
                    Console.ReadKey(True)
                    strFocalLength = ""
                    Console.Clear()
                    Console.Write("Please enter the focal length (cm) " & vbCrLf)
                    strFocalLength = Console.ReadLine()
                    Continue Do
                End If
            Loop
            Console.Write("Please enter the flying height (H) of the aerial camera (in metre) " & vbCrLf)
            strFocalLength = Console.ReadLine()






        Loop





        Console.Write("END TEST" & vbCrLf)
        Console.Write("Press any key to continue . . . " & vbCrLf)
        Console.ReadKey(True)


    End Sub
End Module









#If False Then
         Do While LoopValidation = False
            Console.Write("Please enter the focal length (cm) " & vbCrLf)
            strFocalLength = Console.ReadLine()
            If Double.TryParse(doubleFocalLength, doubleFocalLength) And doubleFocalLength > 0.1 And doubleFocalLength < 99.9 Then
                Console.WriteLine(doubleFocalLength)
                'doubleFocalLength = System.Convert.ToDecimal(strFocalLength)
                LoopValidation = True
            Else
                Do While LoopValidation = False
                    If Decimal.TryParse(strFocalLength, decFocalLength) And decFocalLength > 0.1 And decFocalLength < 99.9 Then
                        Console.WriteLine(decFocalLength)
                        decFocalLength = System.Convert.ToDecimal(strFocalLength)
                        LoopValidation = True
                    Else
                        Console.Write("-------------------------------------------------------------" & vbCrLf)
                        Console.Write("| Error! Please Valid Numeric Value from 0.1 to 99.9         |" & vbCrLf)
                        Console.Write("-------------------------------------------------------------" & vbCrLf & vbCrLf)
                        Console.Write("Press any key to continue . . . ")
                        Console.ReadKey(True)
                        strFocalLength = ""
                        Console.Clear()
                        Console.Write("Please enter the focal length (cm) " & vbCrLf)
                        strFocalLength = Console.ReadLine()
                        Continue Do
                    End If
                Loop
            End If
        Loop
#End If

#If False Then
1.	The focal length (f) of an aerial camera system (in centimetre) 
2.	The flying height (H) of the aerial camera (in metre); 
3.	The elevation (e) of a selected point on a photo created using the system detailed in the above parts 1) and 2) (in metre). 
4.	Calculate the air photo scale at elevation (e) according to the equation:
S = f / (H - e) 
Where S is the air photo scale as a dimensionless ratio (see above for the meanings of f, H, and e). 

The application should display the calculated scale (S) in an appropriate text window or label in the format of notation as 1:xxx,xxx,xxx (note that xxx,xxx,xxx is an integer!). 
Validating Data
1.	The user will be allowed to input only positive values for f between 0.10 and 99.90 cm (inclusive). 
If statements 
2.	Only positive values between 1.0 and 1,000,000.0 m (inclusive) can be input for H, and those between -413.00 and 9,000.00 m (inclusive) can be input for e. The 9,000.00 m is set based on the fact that the peak of the Mount Everest is 8,848m high and the lowest point is -413 at the Dead Sea shore. 

if loops


3.	If the user does not enter the values within these specific ranges, a warning message must show up and the user will have the chance to re-enter their values (Note also (H - e) cannot be less than or equal to 0). 


4.	The user also is allowed to clear the inputs and recalculate the scale. 

Clear all selections by replacing variables with “0” or NULL 



For *Variable* = startnumber to end numbher 
' Body of loop 
Next 


For intYears = 6 to 1 Step -1 
' body of loo;p 
Next 



Do While Condition 
' Body 
Loop 

Do Until Condition 
'body 
Loop Until Condition 


Declaring arrays 

Dim decTemp() As Decimal



Sum = strF \ (h - e)

#End If
