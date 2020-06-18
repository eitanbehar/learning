
//@ts-check
import { question } from 'readline-sync';

function myFunction() {
    let name = question("what's your name: ");
    process.stdout.write("Hello, my name is: ${name}\n");
}

myFunction();