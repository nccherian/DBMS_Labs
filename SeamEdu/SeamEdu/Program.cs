/*
 * Created by SharpDevelop.
 * User: ag.student
 * Date: 01-05-2017
 * Time: 05:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SeamEdu
{
	public class Program
	{
		
		public static void Main (string[]args)
		{
			Node rootNode = null; //Temporary variable 
			
			Console.WriteLine("Please Enter the values in integers and press 'q' to quit \n");

			while(true) //endless loop
			{
				String inputData = Console.ReadLine();
				if(String.Equals(inputData,"q"))
				{
					break;
				}
				try
				{
					int result = Convert.ToInt32(inputData);
					Node node = new Node(result);
					
					if(rootNode==null) 
					{
						rootNode = node;
					}
					else
					{
						Node currentNode;
						currentNode = rootNode;
						
						while()
						{
							if(currentNode.Data > node.Data)
							{
								if(currentNode.Left == null)
								{
									currentNode.Left = node;
									//Console.WriteLine("Left"+currentNode.Left.Data);
								}
								else
								{
									currentNode = currentNode.Left;
								}
							}
							else{
								
							}
						}
					}
					
					Console.WriteLine("Root Node is: " + rootNode.Data);
					Console.WriteLine("Current Node is: " + node.Data);
					
				} 
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
					
		}
	}
}
