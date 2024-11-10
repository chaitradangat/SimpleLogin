import { useState } from "react";


function Login(){


    var [validLogin,setValidLogin] = useState(false); 


    return (
        <>
        <div>
            {validLogin.toString()}
        </div>
        <div>
            <input type="text" id="txtLogin"></input>
        </div>
        <div>
            <input type="text" id="txtPassword"></input>
        </div>
        <div>
            <input type="submit" id="btnLogin" onClick={()=> setValidLogin(!validLogin)}></input>
        </div>
        </>
    );



}

export default Login;