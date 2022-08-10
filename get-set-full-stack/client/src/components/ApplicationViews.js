import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import Login from "./Login";
import Register from "./Register";
import { Home } from "./Home";
import { Track } from "./Track/Track";


export default function ApplicationViews({ isLoggedIn }) {
    return (
        <main>
            <Routes>
                <Route path="/">
                    <Route index element={isLoggedIn ? <Home isLoggedIn={isLoggedIn} /> : <Navigate to="/login" />}
                    />

                    <Route path="track" >
                        <Route index element={isLoggedIn ? <Track isLoggedIn={isLoggedIn} /> : <Navigate to="/login" />} />
                    </Route>

                    <Route path="categories">
                        <Route index element={<p>Category List</p>} />
                        <Route path="create" element={<p>Category Create Form</p>} />
                    </Route>

                    <Route path="users">
                        <Route index element={<p>User List</p>} />
                        <Route path="details/:id" element={<p>User Details</p>} />
                    </Route>

                    <Route path="*" element={<p>Whoops, nothing here...</p>} />
                    <Route path="login" element={<Login />} />
                    <Route path="register" element={<Register />} />
                </Route>
            </Routes>
        </main>
    );
};