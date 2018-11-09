static String newLine = System.lineSeparator();
    
    static LinkedList<Integer> linkedList = new LinkedList<Integer>();
    static ArrayList<Integer> arrayList = new ArrayList<Integer>();
    
    static LinkedList<Integer> linkedList2 = new LinkedList<Integer>();
    static ArrayList<Integer> arrayList2 = new ArrayList<Integer>();
    
    public static void main(String[] args) {
        
        System.out.println("Speed test | ArrayList vs LinkedList:");
        System.out.println("------------------------------------------");
        speedTest();
        System.out.println("------------------------------------------");
    }
    
    private static void speedTest() {
        
        //method for ContainsAll (to check whether arrayList contains arrayList2 and etc.
        for (int i = 0; i < 1000; i++) {
            arrayList2.add(i);
            linkedList2.add(i);
        }
        
        //arrayList add
        long startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            arrayList.add(i);
        }
        
        long endTime = System.nanoTime();
        long duration = endTime - startTime;
        System.out.println("ArrayList pow:  " + duration);

        //linkedList add
        startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            linkedList.add(i);
        }
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("LinkedList add: " + duration);
        
        //arrayList pow
        startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            Math.pow(arrayList.get(i), 0.5);
        }
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("ArrayList pow:  " + duration);

        //linkedList pow
        startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            Math.pow(linkedList.get(i), 0.5);
        }
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("LinkedList pow: " + duration);
        
        //arrayList pow
        startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            Math.sqrt(arrayList.get(i));
        }
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("ArrayList sqrt:  " + duration);

        //linkedList pow
        startTime = System.nanoTime();

        for (int i = 0; i < 100000; i++) {
            Math.sqrt(linkedList.get(i));
        }
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("LinkedList sqrt: " + duration);
        
        //arrayList pow
        startTime = System.nanoTime();

        arrayList.containsAll(arrayList2);
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("ArrayList ContainsAll:  " + duration);

        //linkedList pow
        startTime = System.nanoTime();

        linkedList.containsAll(linkedList2);
        
        endTime = System.nanoTime();
        duration = endTime - startTime;
        System.out.println("LinkedList ContainsAll: " + duration);
        
    }
