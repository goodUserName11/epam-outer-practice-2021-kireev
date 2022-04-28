function RemoveDuplicates(str) 
{
    console.log(str);

    let wordsArr = str.split(' ');

    let duplicatedChar = [];

    wordsArr.forEach(ch => {
        for(let i = 0; i < ch.length; i++) {
            for (let j = i+1; j < ch.length; j++) {
                if(ch[j] == ch[i] && !duplicatedChar.includes(ch[i]))
                    duplicatedChar.push(ch[i]);
            }
        }
    });

    let result = str;

    duplicatedChar.forEach(ch => {
        while(result.includes(ch)) {
            result = result.replace(ch, "");
        }
    });
    
    return result;
}