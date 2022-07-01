// namespace DesignPatern;

// interface IElement{
// 	double ComputeTotal();
// }
// public class FirstElement : IElement{	
// 	double ComputeTotal(){
//   	    return 1;
//     }
// }
// public class SecondElement : IElement{	
// 	double ComputeTotal(){
//   	    return 2;
//     }
// }
// public class CompositeElement : IElement{
//     private List<IElement> elements;
  
//     double ComputeTotal(){
//   	    double total = 0;

//         foreach(var element in elements)
//             total += element.ComputeTotal();
//         return total;
//     }
// }