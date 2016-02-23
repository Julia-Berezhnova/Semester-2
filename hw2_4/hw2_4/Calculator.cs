using NamespaceICalculator;
using NamespaceIStack;

namespace NamespaceCalculator
{
	class Calculator
	{
		private IStack stack;

		public Calculator(IStack stack)
		{
			this.stack = stack;
		}

		public void Add()
		{
			int first = this.stack.Pop();
			int second = this.stack.Pop();
			this.stack.Push(first + second);
		}

		public void Subtract()
		{
			int first = this.stack.Pop();
			int second = this.stack.Pop();
			this.stack.Push(second - first);
		}

		public void Multiply()
		{
			int first = this.stack.Pop();
			int second = this.stack.Pop();
			this.stack.Push(first * second);
		}

		public void Divide()
		{
			int first = this.stack.Pop();
			int second = this.stack.Pop();
			this.stack.Push(second / first);
		}

		public bool Push(int value)
		{
			return this.stack.Push (value);
		}

		public int Result()
		{
			return this.stack.Top ();
		}

	}
}

