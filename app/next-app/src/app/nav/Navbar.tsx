import React from 'react'

export default function Navbar() {
  return (
    <header className='sticky top-0 z-50 flex justify-between bg-white p-5 items-center text-gray-800 shadow-md'>
        <div className='flex w-[50%] items-center border-2 rounded-full py-2 shadow-sm'>
            <input 
            type="text"
            placeholder='Search for projects...'
            className='flex-grow pl-5 bg-transparent focus:outline-none border-transparent focus:ring-0 text-sm text-gray-600' />
        </div>
    </header>
  )
}
