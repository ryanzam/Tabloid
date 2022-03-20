import React, { Component } from 'react';

const Contact = () => {

    return (<>
        <form>
            <div className="form-group">
                <label for="name">Name</label>
                <input type="text" className="form-control" id="name" />
            </div>

            <div className="form-group">
                <label for="email">Email address</label>
                <input type="email" className="form-control" id="email" aria-describedby="emailHelp" />
                <small id="emailHelp" className ="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>

            <div className="form-group">
                <label for="message">Message</label>
                <textarea className="form-control" id="message" rows="5"></textarea>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
        </>)
}

export default Contact