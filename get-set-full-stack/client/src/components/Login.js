import React, { useState } from "react";
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';
import { useNavigate, Link } from "react-router-dom";
import { login } from "../modules/authManager";




export default function Login() {
    const navigate = useNavigate();

    const [email, setEmail] = useState();
    const [password, setPassword] = useState();

    const loginSubmit = (e) => {
        e.preventDefault();
        login(email, password)
            .then(() => navigate("/"))
            .catch(() => alert("Invalid email or password"));
    };

    return (
        <div style={{ display: 'flex', justifyContent: 'center' }}>
            <Form onSubmit={loginSubmit} className="w-4 mt-4">
                <fieldset>
                    <FormGroup>
                        <Label for="email">Email</Label>
                        <Input
                            id="email"
                            type="text"
                            autoFocus
                            onChange={(e) => setEmail(e.target.value)}
                        />
                    </FormGroup>
                    <FormGroup>
                        <Label for="password">Password</Label>
                        <Input
                            id="password"
                            type="password"
                            onChange={(e) => setPassword(e.target.value)}
                        />
                    </FormGroup>
                    <FormGroup className="text-center">
                        <Button>Login</Button>
                    </FormGroup>
                    <FormGroup className="text-center">
                        <em className="text-center">
                            Not registered? <Link to="/register">Register</Link>
                        </em>
                    </FormGroup>
                </fieldset>
            </Form>
        </div>
    );
}