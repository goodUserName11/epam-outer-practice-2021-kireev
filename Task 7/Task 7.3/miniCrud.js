class MiniData {
    constructor(id, name, num, type) {
        if(typeof(id) != "string" || typeof(name) != "string" || typeof(num) != "number" || typeof(type) != "string") {
            console.log("exception: there is bad data. Expected: (String, String, Number, String)");
        }

        this.id = id;
        this.name = name;
        this.num = num;
        this.type = type;
    }
}

class MiniCrudService{
    _dataArray = [];

    constructor() {
    
    }

    add = (data) => {
        if(!(data instanceof MiniData))
        {
            console.log("exception: expected (MiniData)");
            return;
        }

        this._dataArray.push(new MiniData(data.id, data.name, data.num, data.type));
    }

    getAll = () => {
        let newDataArray = [];

        for(let i = 0; i < this._dataArray.length; i++) {
            newDataArray.push(new MiniData(
                this._dataArray[i].id,
                this._dataArray[i].name,
                this._dataArray[i].num,
                this._dataArray[i].type
                )
            );     
        }

        return newDataArray;
    }

    getById = (id) => {
        if(typeof(id) != "string")
        {
            console.log("exception: expected (String)");
            return null;
        }


        let getableData = this._dataArray.find(x => x.id == id);

        if(getableData == null)
            return null;

        let dataWrapper = new MiniData(
            getableData.id,
            getableData.name,
            getableData.num,
            getableData.type
        );  
        
        return dataWrapper
    }

    deleteById = (id) => {
        if(typeof(id) != "string")
        {
            console.log("exception: expected (String)");
            return null;
        }


        let index = this._dataArray.findIndex(x => x.id == id);

        if(index < 0)
            return null;

        let getableData = this._dataArray.splice(index, 1)[0];

        let dataWrapper = new MiniData(
            getableData.id,
            getableData.name,
            getableData.num,
            getableData.type
        ); 
         
        return dataWrapper
    }

    updateById(id, data) {
        if(typeof(id) != "string" || !(data instanceof MiniData))
        {
            console.log("exception: expected (String, MiniData`)");
            return;
        }

        if(id != data.id)
        {
            console.log("exception: id should be even datad.id");
            return;
        }

        let index = this._dataArray.findIndex(x => x.id == id);

        if(index < 0) 
            return;

        this._dataArray[index].name = data.name,
        this._dataArray[index].num = data.num,
        this._dataArray[index].type = data.type
    }

    replaceById(id, data) {
        if(typeof(id) != "string" || !(data instanceof MiniData))
        {
            console.log("exception: expected (String, MiniData)");
            return;
        }

        if(id != data.id)
        {
            console.log("exception: id should be even data.id");
            return;
        }

        this.deleteById(id);
        this.add(data);
    }
}