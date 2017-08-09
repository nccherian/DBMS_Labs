/*
 * Created by SharpDevelop.
 * User: ag.student
 * Date: 01-05-2017
 * Time: 05:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SeamEdu
{
	public class Node
	{
		private int data;
		private Node left;
		private Node right;
		
		public Node Left
		{
			get
			{
				return this.left;
			}
			set
			{
				this.left = value;
			}
		}
		
		public Node Right
		{
			get 
			{
				return this.right;
			}
			set 
			{
				this.right = value;
			}
		}
		
		public int Data //getter for input data
		{
			get
			{
				return data;
			}
		}
		
		public Node(int data) //Constructor
		{
			this.data = data;
		}
	}
}
