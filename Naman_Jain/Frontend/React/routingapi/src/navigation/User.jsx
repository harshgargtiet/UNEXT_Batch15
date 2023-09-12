import React from 'react'
import {useParams} from 'react-router-dom';

const User = () => {

    const { mid } = useParams();
  return (
    <div>
        User Id : {mid}
    </div>
  )
}

export default User