# Domain Joiner
> C# Console Application that uses command line arguments to join a PC to a domain.

Simple & Standalone C# Console application that will join a PC to a domain after it's ran with command line arguments.

[Quick PoC](https://streamable.com/s8ehm)

## Usage example

Windows:

```sh
cmd /k ""c:\support\domain.exe" "domain" "username" "password""
```

Copy the release of this project to a machine that is not currently connected to a domain, save it in a location accessible by an Administrator and run with the 3 arguments above, this will connect the machine to the domain but will require a reboot to complete successfully.

If the program failed to connect to the domain it will log a `failed.txt` document to `c:\support\` with the error code and troubleshooting steps.

## Development setup

Currently no development setup tested, will add testing ability to spoof a connection so you are able to see the reply.

## Release History

* 0.1.0
    * ADD: Add `src\project`
* 0.0.1-pre
    * Project Started
    * ADD: Add `Readme.md`
    * CHANGE: Add `Project Name/Description`
    * FIX: Build Src

## Meta

Charlie Maddex – [@charliemaddex](https://maddex.co) – charlie@maddex.co

[https://github.com/name/domain-join](https://github.com/name/)

## Contributing

1. Fork it (<https://github.com/name/domain-join/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Commit your changes (`git commit -am 'Add some fooBar'`)
4. Push to the branch (`git push origin feature/fooBar`)
5. Create a new Pull Request
