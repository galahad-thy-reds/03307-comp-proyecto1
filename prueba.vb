Imports System
Imports System.IO

Modular Program
Modul Progr
Module Programa
Module Program

Imports System.IO
    Sub Main(
	  args As String()
	 )
	Sub Main(args As String()
    Sub Main args As String())
    Sub Main(args As String())
        Console.WriteLine("==========================================================")
        Console.WriteLine("        Este codigo lo que hace es leer un archivo")
        Console.WriteLine("==========================================================")
		"Declaracion de variables
		Declaracion de variables'
		--Declara variables
        'Declaracion de variables
		Di LecturaArchivo As IO.StreamReader
		Dim LecturaArchivo  IO.StreamReader
        Dim LecturaArchivo As IO.StreamReader
		
        Dim Lineatexto  Cadena
		
		Dim Lineatexto As String
		
		Dim prueba1 As String
		Dim prueba2 As String
		Dim prueba3 As String
		
        Dim Bandera As Boolean = False
        Dim NombreArchivo As String = "curso.txt"

        'Realiza la lectura del archivo
        LecturaArchivo = New IO.StreamReader(NombreArchivo)
        Try

            While  Banderas
                Lineatexto = LecturaArchivo.ReadLine()               
            End While

            
	            While Not Bandera
                Lineatexto = LecturaArchivo.ReadLine()               
            End 

            While Bandera
			  Lineatexto = LecturaArchivo.ReadLine()               
            End While
					
            While  Bandera                
				
            End While

            'Se cierra el archivo
            LecturaArchivo.Close()
        Catch problema As Exception
		'Hay un error
            Console.WriteLine("Ha ocurrido un inconveniente en el proceso de lectura" + problema.Message())
        End Try
		'Fin de try
		
		Try		
		 Bandera = true
	    Catch Exception
		  Console.WriteLine("prueba de try #1")		
		End Catch 
		
		Try		
		 Bandera = true
	    Catch problema As Exception
		  Console.WriteLine("prueba de try #2")		
		End 

		
		 Bandera = true
	    Catch problema As Exception
		  Console.WriteLine("prueba de try #3")		
		End Try
		
		Try		
		 Bandera = true
	    Catch problema As Exception
		  Console.WriteLine("prueba de try #4")		
		End Try 		
		
        Console.WriteLine("==========================================================")
	Final Sub	
	End Su	
    End Sub

End Module
