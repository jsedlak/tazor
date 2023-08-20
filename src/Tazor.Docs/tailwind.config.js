/** @type {import('tailwindcss').Config} */
//let fs = require("fs")

//const readFileLines = filename =>
//    fs.readFileSync(filename)
//        .toString('UTF8')
//        .split('\n');

//let knownClasses = readFileLines('tailwind.classes.txt');

module.exports = {
    darkMode: 'class',
    content: ["./**/*.{razor,html,cshtml}", "./**/themes/*.theme.json"],
    theme: {
        extend: {},
    },
    plugins: [],
}

