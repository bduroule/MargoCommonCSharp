// // producer consumer
// namespace DesignPatern;

// interface IProducer {
// 	IConsumer Produce<T>(T item);
// }
// interface IConsumer {
// 	void Consume();
// }

// public class MyClass<T> {

//     public readonly Queue<T> mainQueue = new Queue<T>();
//     public readonly IProducer producer;

//     public void Add(T item){
//         queue.Enqueu(item);
//     }

//     public void Work() {
//         while(!queue.IsEmpty){
//             var nextElement = queue.Dequeue();
//             var consumer = producer.Produce(nextElement);
//             consumer.Consume();
//         }
//     }
// }
 
//  // -------------------------------- PC MULTITHREADING ----------------------------------

// interface IProducer {
// 	IConsumer Produce<T>(T item);
// }
// interface IConsumer {
// 	void Consume();
// }

// public class MyClass<T> {
//     public readonly Queue<T> mainQueue = new Queue<T>();
//     private readonly Queue<IConsumer> consumers = new Queue<T>();
//     public readonly IProducer producer;
//     private Thread producerThread;
//     private Thread consumerThread;

//     public void Init(){
//         consumerThread = new Thread(ConsumerWork);
//         producerThread = new Thread(ProducerWork);
//         producerThread.Start();
//         consumerThread.Start();
//     }

//     public void Add(T item){
//         queue.Enqueue(item);
//     }

//     public void ProducerWork() {
//         while(!queue.IsEmpty) {
//             var nextElement = queue.Dequeue();
//             var consumer = producer.Produce(nextElement);
//             consumers.Enqueue(consumer);
//         }  
//     }
//     public void ConsumerWork() {
//         while(!consumers.IsEmpty) {
//             var nextElement = consumers.Dequeue();
//             nextElements.Consume();
//         }
//     }
// }
