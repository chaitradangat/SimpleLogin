import { useState } from "react";

function Login(){

    var [displayinput,toggleDisplay] = useState(false);

    let abc = displayinput.toString();

    console.log(abc);

    return (
    <>
    Login Component {abc}
    <div>
        <div>
            <input id="txtLogin" type="text"></input>
        </div>
        <div>
            <input id="txtPassword" type="text"></input>
        </div>
        <div>
            <button id="btnLogin" type="submit" onClick={()=> toggleDisplay(!displayinput) } >Login</button>
        </div>
    </div>
    </>)
}

export default Login;